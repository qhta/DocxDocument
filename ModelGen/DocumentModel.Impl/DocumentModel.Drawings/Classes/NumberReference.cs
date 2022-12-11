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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Formula{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public NumberingCache? NumberingCache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public NumRefExtensionList? NumRefExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
