namespace DocumentModel.Math;


/// <summary>
///   Office Math Paragraph Properties.
/// </summary>
public partial class ParagraphProperties
{
  
  /// <summary>
  ///   Justification.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Math.JustificationValues? Justification { get; set; }
  
}
