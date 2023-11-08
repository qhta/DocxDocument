namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate WordPerfect 5.x Line Spacing.
/// </summary>
public partial class SuppressTopSpacingWordPerfect: ModelElement<DXW.SuppressTopSpacingWordPerfect>
{
  public SuppressTopSpacingWordPerfect(): base(){ }
  
  public SuppressTopSpacingWordPerfect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressTopSpacingWordPerfect(DXW.SuppressTopSpacingWordPerfect openXmlElement): base(openXmlElement) { }
  
}
