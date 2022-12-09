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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Formula{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public StringCache? StringCache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public StrRefExtensionList? StrRefExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
