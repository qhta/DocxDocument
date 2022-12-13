namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public class TextListStyleTypeImpl: ModelElementImpl, TextListStyleType
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextListStyleTypeImpl(): base() {}
  
  public TextListStyleTypeImpl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  public DocumentModel.Drawings.DefaultParagraphProperties? DefaultParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level1ParagraphProperties? Level1ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level2ParagraphProperties? Level2ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level3ParagraphProperties? Level3ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level4ParagraphProperties? Level4ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level5ParagraphProperties? Level5ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level6ParagraphProperties? Level6ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level7ParagraphProperties? Level7ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level8ParagraphProperties? Level8ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level9ParagraphProperties? Level9ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
