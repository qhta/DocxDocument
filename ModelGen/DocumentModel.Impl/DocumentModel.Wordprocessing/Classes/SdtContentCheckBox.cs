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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Checked>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.Checked{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
