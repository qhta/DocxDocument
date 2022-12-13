namespace DocumentModel.Drawings.Charts;

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
  
  public StringReferenceImpl(): base() {}
  
  public StringReferenceImpl(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get => (System.String?)OpenXmlElement?.Formula?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Formula != null)
        {
          if (value is not null)
            OpenXmlElement.Formula.Text = value;
          else
            OpenXmlElement.Formula = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Formula = new DocumentFormat.OpenXml.Drawing.Charts.Formula{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringCache? StringCache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.StrRefExtensionList? StrRefExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
