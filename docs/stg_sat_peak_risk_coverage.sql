{{ config(tags = ['policy']) }}

{%- set metadata_yaml -%}
source_model: 'stg_sat_peak_risk_coverage_pre'
include_source_columns: true
derived_columns:
  RECORD_SOURCE: '!PEAK'
  COVERAGE_CODE: 'COVERAGECODE'
  LIMIT_CODE: 'LIMITCODE'
  DEDUCTIBLE_CODE: 'DEDUCTIBLECODE'
  STATE_CODE: 'STATECODE'
  EFFECTIVE_TIMESTAMP: 'EFFECTIVEDATE'
  COVERAGE_NK: 
    - 'COVERAGE_CODE'
    - 'LIMIT_CODE'
    - 'DEDUCTIBLE_CODE'
    - 'STATE_CODE'
hashed_columns:
  POLICY_HK: 'POLICY_ID'
  VEHICLE_HK: 'VEHICLE_ID'
  COVERAGE_HK: 'COVERAGE_NK'
  TRANSACTION_HK: 'POLICYREADONLYHISTORYID'
  POLICY_HAS_VEHICLE_COVERAGE_HK:
    - 'POLICY_HK'
    - 'VEHICLE_HK'
    - 'COVERAGE_HK'
  VEHICLE_HK: 'VEHICLE_ID'
  HASHDIFF:
    is_hashdiff: true
    exclude_columns: true
    columns:
      - 'CONFORMED_DIGEST'
      - 'CONFORMED_INGESTION_TS'
{%- endset -%}

{% set metadata_dict = fromyaml(metadata_yaml) -%}

{% set source_model = metadata_dict['source_model'] -%}
{% set include_source_columns = metadata_dict['include_source_columns'] -%}
{% set hashed_columns = metadata_dict['hashed_columns'] -%}
{% set derived_columns = metadata_dict['derived_columns'] -%}

WITH stg AS (
  {{ dbtvault.stage(include_source_columns=include_source_columns,
                      source_model=source_model,
                      hashed_columns=hashed_columns,
                      derived_columns=derived_columns) }} 
  {{ limit_records() }}
),
stg_loadtimestamp AS (
  {{ append_loadtimestamp(stage_name = 'stg') }}
)

SELECT * FROM stg_loadtimestamp