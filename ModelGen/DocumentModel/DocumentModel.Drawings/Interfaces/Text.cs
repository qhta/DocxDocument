namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public interface Text // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// TextData.
  /// </summary>
  public TextData? TextData { get ; set; }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public RichTextBody? RichTextBody { get ; set; }
  
}
