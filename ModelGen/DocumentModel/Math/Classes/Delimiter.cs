namespace DocumentModel.Math;


/// <summary>
///   Delimiter Function.
/// </summary>
public partial class Delimiter
{
  
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Math.DelimiterProperties? DelimiterProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Math.Base>? Items { get; set; }
  
}
