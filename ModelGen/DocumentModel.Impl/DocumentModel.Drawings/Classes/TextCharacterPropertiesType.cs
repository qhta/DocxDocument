namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public class TextCharacterPropertiesTypeImpl: ModelElementImpl, TextCharacterPropertiesType
{
  public DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextCharacterPropertiesTypeImpl(): base() {}
  
  public TextCharacterPropertiesTypeImpl(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? SmtClean
  {
    get => (System.Boolean?)OpenXmlElement?.SmtClean?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmtClean = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public UInt32? SmtId
  {
    get => (System.UInt32?)OpenXmlElement?.SmtId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmtId = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public Boolean? Kumimoji
  {
    get => (System.Boolean?)OpenXmlElement?.Kumimoji?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Kumimoji = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language
  {
    get => (System.String?)OpenXmlElement?.Language?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = (System.String?)value;
    }
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  public String? AlternativeLanguage
  {
    get => (System.String?)OpenXmlElement?.AlternativeLanguage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlternativeLanguage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// sz
  /// </summary>
  public Int32? FontSize
  {
    get => (System.Int32?)OpenXmlElement?.FontSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontSize = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// b
  /// </summary>
  public Boolean? Bold
  {
    get => (System.Boolean?)OpenXmlElement?.Bold?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bold = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// i
  /// </summary>
  public Boolean? Italic
  {
    get => (System.Boolean?)OpenXmlElement?.Italic?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Italic = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// u
  /// </summary>
  public DocumentModel.Drawings.TextUnderlineKind? Underline
  {
    get => (DocumentModel.Drawings.TextUnderlineKind?)OpenXmlElement?.Underline?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Underline = (DocumentFormat.OpenXml.Drawing.TextUnderlineValues?)value;
    }
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public DocumentModel.Drawings.TextStrikeKind? Strike
  {
    get => (DocumentModel.Drawings.TextStrikeKind?)OpenXmlElement?.Strike?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Strike = (DocumentFormat.OpenXml.Drawing.TextStrikeValues?)value;
    }
  }
  
  /// <summary>
  /// kern
  /// </summary>
  public Int32? Kerning
  {
    get => (System.Int32?)OpenXmlElement?.Kerning?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Kerning = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public DocumentModel.Drawings.TextCapsKind? Capital
  {
    get => (DocumentModel.Drawings.TextCapsKind?)OpenXmlElement?.Capital?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Capital = (DocumentFormat.OpenXml.Drawing.TextCapsValues?)value;
    }
  }
  
  /// <summary>
  /// spc
  /// </summary>
  public Int32? Spacing
  {
    get => (System.Int32?)OpenXmlElement?.Spacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Spacing = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public Boolean? NormalizeHeight
  {
    get => (System.Boolean?)OpenXmlElement?.NormalizeHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NormalizeHeight = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  public Int32? Baseline
  {
    get => (System.Int32?)OpenXmlElement?.Baseline?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Baseline = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  public Boolean? NoProof
  {
    get => (System.Boolean?)OpenXmlElement?.NoProof?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoProof = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  public Boolean? Dirty
  {
    get => (System.Boolean?)OpenXmlElement?.Dirty?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dirty = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// err
  /// </summary>
  public Boolean? SpellingError
  {
    get => (System.Boolean?)OpenXmlElement?.SpellingError?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SpellingError = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public Boolean? SmartTagClean
  {
    get => (System.Boolean?)OpenXmlElement?.SmartTagClean?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmartTagClean = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  public UInt32? SmartTagId
  {
    get => (System.UInt32?)OpenXmlElement?.SmartTagId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmartTagId = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  public String? Bookmark
  {
    get => (System.String?)OpenXmlElement?.Bookmark?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bookmark = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public virtual DocumentModel.Drawings.Outline? Outline
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
