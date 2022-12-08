namespace DocumentModel.Drawings;

/// <summary>
/// Number Reference.
/// </summary>
public class NumberReferenceImpl: ModelElementImpl, NumberReference
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumberReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberReference?)_OpenXmlElement;
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
  /// NumberingCache.
  /// </summary>
  public NumberingCache? NumberingCache
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public NumRefExtensionList? NumRefExtensionList
  {
    get;
    set;
  }
  
}
