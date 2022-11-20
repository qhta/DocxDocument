namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextEffect Class.
/// </summary>
public interface ITextEffect // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Animated Text Effect Type
  /// </summary>
  public TextEffectValues? Val { get ; set; }
  
}
