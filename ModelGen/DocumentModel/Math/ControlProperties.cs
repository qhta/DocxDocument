namespace DocumentModel.Math;


/// <summary>
///   Control Properties.
/// </summary>
public partial class ControlProperties
{
  public DMW.RunProperties? RunProperties { get; set; }
  
  public DMW.InsertedMathControl? InsertedMathControl { get; set; }
  
  public DMW.DeletedMathControl? DeletedMathControl { get; set; }
  
  public DMW.MoveFromMathControl? MoveFromMathControl { get; set; }
  
  public DMW.MoveToMathControl? MoveToMathControl { get; set; }
  
}
