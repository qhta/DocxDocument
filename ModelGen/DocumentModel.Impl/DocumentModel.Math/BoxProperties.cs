namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBreak))]
[ChildElementInfo(typeof(DocumentModel.Math.IOperatorEmulator))]
[ChildElementInfo(typeof(DocumentModel.Math.INoBreak))]
[ChildElementInfo(typeof(DocumentModel.Math.IDifferential))]
[ChildElementInfo(typeof(DocumentModel.Math.IAlignment))]
public class BoxProperties: IBoxProperties
{
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  public IOperatorEmulator? OperatorEmulator
  {
    get;
    set;
  }
  
  /// <summary>
  /// No Break.
  /// </summary>
  public INoBreak? NoBreak
  {
    get;
    set;
  }
  
  /// <summary>
  /// Differential.
  /// </summary>
  public IDifferential? Differential
  {
    get;
    set;
  }
  
  /// <summary>
  /// Break.
  /// </summary>
  public DocumentModel.Math.IBreak? Break
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public DocumentModel.Math.IAlignment? Alignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
