namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public class SdtContentCheckBoxImpl: ModelElementImpl, SdtContentCheckBox
{
  public DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtContentCheckBoxImpl(): base() {}
  
  public SdtContentCheckBoxImpl(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Checked.
  /// </summary>
  public OnOffKind? Checked
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Checked>();
        return (OnOffKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Checked>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.Checked{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public CheckBoxSymbolType? CheckedState
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public CheckBoxSymbolType? UncheckedState
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
