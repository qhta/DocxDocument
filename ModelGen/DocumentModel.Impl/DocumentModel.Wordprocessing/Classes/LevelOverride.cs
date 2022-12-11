namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public class LevelOverrideImpl: ModelElementImpl, LevelOverride
{
  public DocumentFormat.OpenXml.Wordprocessing.LevelOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LevelOverride?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (Int32?)OpenXmlElement?.LevelIndex?.Value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.StartOverrideNumberingValue{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public Level? Level
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
