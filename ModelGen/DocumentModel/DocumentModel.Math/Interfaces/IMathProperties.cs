namespace DocumentModel.Math;

/// <summary>
/// Math Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBreakBinary))]
[ChildElementInfo(typeof(DocumentModel.Math.IBreakBinarySubtraction))]
[ChildElementInfo(typeof(DocumentModel.Math.IMathFont))]
[ChildElementInfo(typeof(DocumentModel.Math.IIntegralLimitLocation))]
[ChildElementInfo(typeof(DocumentModel.Math.INaryLimitLocation))]
[ChildElementInfo(typeof(DocumentModel.Math.IDefaultJustification))]
[ChildElementInfo(typeof(DocumentModel.Math.ISmallFraction))]
[ChildElementInfo(typeof(DocumentModel.Math.IDisplayDefaults))]
[ChildElementInfo(typeof(DocumentModel.Math.IWrapRight))]
[ChildElementInfo(typeof(DocumentModel.Math.ILeftMargin))]
[ChildElementInfo(typeof(DocumentModel.Math.IRightMargin))]
[ChildElementInfo(typeof(DocumentModel.Math.IPreSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IPostSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IInterSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IIntraSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IWrapIndent))]
public interface IMathProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Math Font.
  /// </summary>
  public IMathFont? MathFont { get ; set; }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public IBreakBinary? BreakBinary { get ; set; }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public IBreakBinarySubtraction? BreakBinarySubtraction { get ; set; }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public ISmallFraction? SmallFraction { get ; set; }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public IDisplayDefaults? DisplayDefaults { get ; set; }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public DocumentModel.Math.ILeftMargin? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public DocumentModel.Math.IRightMargin? RightMargin { get ; set; }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public IDefaultJustification? DefaultJustification { get ; set; }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public IPreSpacing? PreSpacing { get ; set; }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public IPostSpacing? PostSpacing { get ; set; }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public IInterSpacing? InterSpacing { get ; set; }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public IIntraSpacing? IntraSpacing { get ; set; }
  
}
