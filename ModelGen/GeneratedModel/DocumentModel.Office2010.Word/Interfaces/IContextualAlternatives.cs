namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ContextualAlternatives Class.
/// </summary>
public interface IContextualAlternatives // : DocumentFormat.OpenXml.Office2010.Word.OnOffType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOff? Val { get ; set; }
  
}
