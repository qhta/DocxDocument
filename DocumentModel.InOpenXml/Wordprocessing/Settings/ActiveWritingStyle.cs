namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies information about the parameters of the grammar checking 
///   which was performed on the contents of the current WordprocessingML document. 
/// </summary>
public partial class ActiveWritingStyle : ModelElement<DXW.ActiveWritingStyle>
{
    /// <summary>
    ///   Specifies the name of the application which specified the grammatical settings 
    ///   contained on the attributes for this element.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ActiveWritingStyle.ApplicationName))]
    /// <summary>
    ///   Specifies the name of the application which specified the grammatical settings 
    ///   contained on the attributes for this element.
    /// </summary>
    [OpenXmlElement(typeof(DXW.ActiveWritingStyle))]
    public string? ApplicationName { get => _ApplicationName; set => UpdateField(ref _ApplicationName, value, nameof(ApplicationName)); }

    private string? _ApplicationName;
    /// <summary>
    ///   Specifies if the grammar content checking performed on this document 
    ///   included stylistic rules for the document content. 
    ///   If specified, applications which support this functionality shall check stylistic rules 
    ///   as well as grammatical ones when checking the grammatical content of this document. 
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ActiveWritingStyle.CheckStyle))]
    /// <summary>
    ///   Specifies if the grammar content checking performed on this document 
    ///   included stylistic rules for the document content. 
    ///   If specified, applications which support this functionality shall check stylistic rules 
    ///   as well as grammatical ones when checking the grammatical content of this document. 
    /// </summary>
    [OpenXmlElement(typeof(DXW.ActiveWritingStyle))]
    public bool? CheckStyle { get => _CheckStyle; set => UpdateField(ref _CheckStyle, value, nameof(CheckStyle)); }

    private bool? _CheckStyle;
    /// <summary>
    ///   Specifies the version of the engine that was used to check the grammatical content 
    ///   of the WordprocessingML document.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ActiveWritingStyle.DllVersion))]
    /// <summary>
    ///   Specifies the version of the engine that was used to check the grammatical content 
    ///   of the WordprocessingML document.
    /// </summary>
    [OpenXmlElement(typeof(DXW.ActiveWritingStyle))]
    public Int32? DllVersion { get => _DllVersion; set => UpdateField(ref _DllVersion, value, nameof(DllVersion)); }

    private Int32? _DllVersion;
    /// <summary>
    ///   Specifies a value indicating a unique ID for the writing style engine 
    ///   that was used to check the grammatical content of the WordprocessingML document.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ActiveWritingStyle.VendorID))]
    /// <summary>
    ///   Specifies a value indicating a unique ID for the writing style engine 
    ///   that was used to check the grammatical content of the WordprocessingML document.
    /// </summary>
    [OpenXmlElement(typeof(DXW.ActiveWritingStyle))]
    public UInt16? VendorID { get => _VendorID; set => UpdateField(ref _VendorID, value, nameof(VendorID)); }

    private UInt16? _VendorID;
    /// <summary>
    ///   Specifies the language of the engine used to perform the grammatical content checking.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ActiveWritingStyle.Language))]
    /// <summary>
    ///   Specifies the language of the engine used to perform the grammatical content checking.
    /// </summary>
    [OpenXmlElement(typeof(DXW.ActiveWritingStyle))]
    public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }

    private string? _Language;
    /// <summary>
    ///   Specifies whether the engine that was used to check the grammatical content 
    ///   of the WordprocessingML document performed natural language-based analysis.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.ActiveWritingStyle.NaturalLanguageGrammarCheck))]
    /// <summary>
    ///   Specifies whether the engine that was used to check the grammatical content 
    ///   of the WordprocessingML document performed natural language-based analysis.
    /// </summary>
    [OpenXmlElement(typeof(DXW.ActiveWritingStyle))]
    public bool? NaturalLanguageGrammarCheck { get => _NaturalLanguageGrammarCheck; set => UpdateField(ref _NaturalLanguageGrammarCheck, value, nameof(NaturalLanguageGrammarCheck)); }

    private bool? _NaturalLanguageGrammarCheck;
}