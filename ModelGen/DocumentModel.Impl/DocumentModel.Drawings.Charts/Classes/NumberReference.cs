namespace DocumentModel.Drawings.Charts;

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
  
  public NumberReferenceImpl(): base() {}
  
  public NumberReferenceImpl(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement): base(openXmlElement)
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
  /// NumberingCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingCache? NumberingCache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumRefExtensionList? NumRefExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
