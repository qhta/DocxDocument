namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public class CreationIdImpl: ModelElementImpl, CreationId
{
  public DocumentFormat.OpenXml.Office2016.Drawing.CreationId? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.CreationId?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
