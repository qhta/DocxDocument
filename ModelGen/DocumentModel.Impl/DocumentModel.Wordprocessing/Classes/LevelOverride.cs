namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public partial class LevelOverrideImpl: ModelElementImpl, LevelOverride
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.LevelOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LevelOverride?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LevelOverrideImpl(): base() {}
  
  public LevelOverrideImpl(DocumentFormat.OpenXml.Wordprocessing.LevelOverride openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public Int32? LevelIndex
  {
    get => (System.Int32?)OpenXmlElement?.LevelIndex?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LevelIndex = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public Int32? StartOverrideNumberingValue
  {
    get => (System.Int32?)OpenXmlElement?.StartOverrideNumberingValue?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StartOverrideNumberingValue != null)
        {
          if (value is not null)
            OpenXmlElement.StartOverrideNumberingValue.Val = (System.Int32?)value;
          else
            OpenXmlElement.StartOverrideNumberingValue = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StartOverrideNumberingValue = new DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.Level? Level
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Level>();
        if (item != null)
          return new DocumentModel.Wordprocessing.LevelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Level>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.LevelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
