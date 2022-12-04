namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public class TextOutlineEffect
{
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public LineCapKind? CapType
  {
    get;
    set;
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public CompoundLineKind? Compound
  {
    get;
    set;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public PenAlignmentKind? Alignment
  {
    get;
    set;
  }
  
  public SolidColorFillProperties? SolidColorFillProperties
  {
    get;
    set;
  }
  
  public GradientFillProperties? GradientFillProperties
  {
    get;
    set;
  }
  
  public PresetLineDashKind? PresetLineDashProperties
  {
    get;
    set;
  }
  
  public LineJoinMiterProperties? LineJoinMiterProperties
  {
    get;
    set;
  }
  
}
