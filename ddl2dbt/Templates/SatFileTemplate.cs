﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ddl2dbt.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SatFileTemplate : SatFileTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("{{ config(tags = [");
            
            #line 6 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
for(int count=0; count < SatTableMetadata.Tags.Count(); count++)
                   {
            
            #line default
            #line hidden
            this.Write("\'");
            
            #line 7 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.Tags[count]));
            
            #line default
            #line hidden
            this.Write("\'");
            
            #line 7 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

                    if(count != SatTableMetadata.Tags.Count()-1)
                        {
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 9 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 9 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

                    }
            
            #line default
            #line hidden
            this.Write("]");
            
            #line 10 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 if(SatTableMetadata.MaskedColumnsPresent){ 
            
            #line default
            #line hidden
            this.Write(",\r\n   post_hook = [");
            
            #line 11 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

                    for(int count=0; count < SatTableMetadata.MaskedColumns.Count(); count++)
                        {
                            
            
            #line default
            #line hidden
            this.Write("\"{{ masking_policy(\'");
            
            #line 14 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.MaskedColumns[count].Label));
            
            #line default
            #line hidden
            this.Write("\', \'");
            
            #line 14 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.MaskedColumns[count].Value));
            
            #line default
            #line hidden
            this.Write("\') }}\"");
            
            #line 14 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

                    if(count != SatTableMetadata.MaskedColumns.Count()-1)
                        {
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 17 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 17 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

                        }
            
            #line default
            #line hidden
            this.Write("\r\n               ]\r\n");
            
            #line 21 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(")}}\r\n\r\n{%- set metadata_yaml -%}\r\nsource_model: ");
            
            #line 24 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 if (SatTableMetadata.SourceModel.Count == 1)
        { 
            
            #line default
            #line hidden
            this.Write("\'");
            
            #line 25 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.SourceModel[0]));
            
            #line default
            #line hidden
            this.Write("\'\r\n");
            
            #line 26 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 26 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 else
        { 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 29 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

    foreach (var model in SatTableMetadata.SourceModel)
    {
            
            #line default
            #line hidden
            this.Write("    - \'");
            
            #line 32 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model));
            
            #line default
            #line hidden
            this.Write("\'\r\n");
            
            #line 33 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 }
            
            #line default
            #line hidden
            
            #line 34 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("src_pk: \'");
            
            #line 35 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.SrcPk));
            
            #line default
            #line hidden
            this.Write("\'\r\n");
            
            #line 36 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

if(SatTableMetadata.IsFIleTypeMAS)
{
            
            #line default
            #line hidden
            this.Write("src_cdk:\r\n");
            
            #line 40 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

    foreach (var key in SatTableMetadata.SrcCdk)
    {
            
            #line default
            #line hidden
            this.Write("  - \'");
            
            #line 43 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key));
            
            #line default
            #line hidden
            this.Write("\'\r\n");
            
            #line 44 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 }}

            
            #line default
            #line hidden
            this.Write("src_hashdiff: \'");
            
            #line 46 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.SrcHashDiff));
            
            #line default
            #line hidden
            this.Write("\'\r\nsrc_eff: \'");
            
            #line 47 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.SrcEff));
            
            #line default
            #line hidden
            this.Write("\'\r\nsrc_ldts: \'");
            
            #line 48 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.SrcLdts));
            
            #line default
            #line hidden
            this.Write("\'\r\nsrc_source: \'");
            
            #line 49 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SatTableMetadata.SrcSource));
            
            #line default
            #line hidden
            this.Write("\'\r\nsrc_payload:\r\n");
            
            #line 51 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

    foreach (var column in SatTableMetadata.SrcPayload)
    {
            
            #line default
            #line hidden
            this.Write("  - \'");
            
            #line 54 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(column));
            
            #line default
            #line hidden
            this.Write("\'\r\n");
            
            #line 55 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 }
            
            #line default
            #line hidden
            this.Write("{%- endset -%}\r\n\r\n{% set metadata_dict = fromyaml(metadata_yaml) -%}\r\n{% set sour" +
                    "ce_model = metadata_dict[\'source_model\'] -%}\r\n{% set src_pk = metadata_dict[\'src" +
                    "_pk\'] -%}\r\n");
            
            #line 61 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

if(SatTableMetadata.IsFIleTypeMAS)
{
            
            #line default
            #line hidden
            this.Write("{% set src_cdk = metadata_dict[\'src_cdk\'] -%}\r\n");
            
            #line 65 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 }

            
            #line default
            #line hidden
            this.Write(@"{% set src_hashdiff = metadata_dict['src_hashdiff'] -%}
{% set src_payload = metadata_dict['src_payload'] -%}
{% set src_eff = metadata_dict['src_eff'] -%}
{% set src_ldts = metadata_dict['src_ldts'] -%}
{% set src_source = metadata_dict['src_source'] -%}

{{ dbtvault.");
            
            #line 73 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
if(SatTableMetadata.IsFIleTypeMAS){
            
            #line default
            #line hidden
            this.Write("ma_");
            
            #line 73 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 }
            
            #line default
            #line hidden
            this.Write("sat(src_pk=src_pk, \r\n");
            
            #line 74 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"

if(SatTableMetadata.IsFIleTypeMAS)
{
            
            #line default
            #line hidden
            this.Write("                src_cdk=src_cdk,\r\n");
            
            #line 78 "D:\ddl2dbt cr\ddl2dbt\ddl2dbt\Templates\SatFileTemplate.tt"
 }

            
            #line default
            #line hidden
            this.Write("                src_hashdiff=src_hashdiff, \r\n                src_payload=src_payl" +
                    "oad,\r\n                src_eff=src_eff, \r\n                src_ldts=src_ldts,\r\n   " +
                    "             src_source=src_source,\r\n                source_model=source_model) " +
                    "}}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class SatFileTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
