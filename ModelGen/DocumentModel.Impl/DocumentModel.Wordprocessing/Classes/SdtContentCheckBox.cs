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
  public DocumentModel.Wordprocessing.OnOffKind? Checked
  {
    get => (DocumentModel.Wordprocessing.OnOffKind?)OpenXmlElement?.Checked?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Checked != null)
        {
          if (value is not null)
            OpenXmlElement.Checked.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            OpenXmlElement.Checked = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Checked = new DocumentFormat.OpenXml.Office2010.Word.Checked{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckBoxSymbolType? CheckedState
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CheckBoxSymbolTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CheckBoxSymbolTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckBoxSymbolType? UncheckedState
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CheckBoxSymbolTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CheckBoxSymbolTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
