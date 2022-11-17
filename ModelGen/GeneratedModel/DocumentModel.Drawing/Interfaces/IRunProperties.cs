namespace DocumentModel.Drawing;

public interface IRunProperties // : DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType
{
  public bool? SmtClean { get ; set; }

  public uint? SmtId { get ; set; }

  public bool? Kumimoji { get ; set; }

  public string? Language { get ; set; }

  public string? AlternativeLanguage { get ; set; }

  public int? FontSize { get ; set; }

  public bool? Bold { get ; set; }

  public bool? Italic { get ; set; }

  public TextUnderline? Underline { get ; set; }

  public TextStrike? Strike { get ; set; }

  public int? Kerning { get ; set; }

  public TextCaps? Capital { get ; set; }

  public int? Spacing { get ; set; }

  public bool? NormalizeHeight { get ; set; }

  public int? Baseline { get ; set; }

  public bool? NoProof { get ; set; }

  public bool? Dirty { get ; set; }

  public bool? SpellingError { get ; set; }

  public bool? SmartTagClean { get ; set; }

  public uint? SmartTagId { get ; set; }

  public string? Bookmark { get ; set; }

  public DocumentModel.Drawing.IOutline? Outline { get ; set; }

}
