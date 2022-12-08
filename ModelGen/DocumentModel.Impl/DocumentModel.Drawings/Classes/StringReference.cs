namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public class StringReferenceImpl: ModelElementImpl, StringReference
{
  public DocumentFormat.OpenXml.Drawing.Charts.StringReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public StringCache? StringCache
  {
    get;
    set;
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public StrRefExtensionList? StrRefExtensionList
  {
    get;
    set;
  }
  
}
