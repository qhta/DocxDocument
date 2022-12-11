namespace DocumentModel.Wordprocessing;

/// <summary>
/// Suggested Filtering for List of Document Styles.
/// </summary>
public class StylePaneFormatFilterImpl: ModelElementImpl, StylePaneFormatFilter
{
  public DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StylePaneFormatFilterImpl(): base() {}
  
  public StylePaneFormatFilterImpl(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public DocumentModel.HexBinaryValue? Val
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AllStyles
  {
    get => (Boolean?)OpenXmlElement?.AllStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? CustomStyles
  {
    get => (Boolean?)OpenXmlElement?.CustomStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CustomStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LatentStyles
  {
    get => (Boolean?)OpenXmlElement?.LatentStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LatentStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StylesInUse
  {
    get => (Boolean?)OpenXmlElement?.StylesInUse?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StylesInUse = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? HeadingStyles
  {
    get => (Boolean?)OpenXmlElement?.HeadingStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HeadingStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NumberingStyles
  {
    get => (Boolean?)OpenXmlElement?.NumberingStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberingStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? TableStyles
  {
    get => (Boolean?)OpenXmlElement?.TableStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TableStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnRuns
  {
    get => (Boolean?)OpenXmlElement?.DirectFormattingOnRuns?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DirectFormattingOnRuns = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnParagraphs
  {
    get => (Boolean?)OpenXmlElement?.DirectFormattingOnParagraphs?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DirectFormattingOnParagraphs = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnNumbering
  {
    get => (Boolean?)OpenXmlElement?.DirectFormattingOnNumbering?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DirectFormattingOnNumbering = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnTables
  {
    get => (Boolean?)OpenXmlElement?.DirectFormattingOnTables?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DirectFormattingOnTables = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ClearFormatting
  {
    get => (Boolean?)OpenXmlElement?.ClearFormatting?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ClearFormatting = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Top3HeadingStyles
  {
    get => (Boolean?)OpenXmlElement?.Top3HeadingStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Top3HeadingStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? VisibleStyles
  {
    get => (Boolean?)OpenXmlElement?.VisibleStyles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VisibleStyles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AlternateStyleNames
  {
    get => (Boolean?)OpenXmlElement?.AlternateStyleNames?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlternateStyleNames = (System.Boolean?)value;
    }
  }
  
}
