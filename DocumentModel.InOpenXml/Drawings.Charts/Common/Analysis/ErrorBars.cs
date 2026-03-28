namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of error bar definitions for a chart series or data points.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties"/> <c>&lt;c:spPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.NoEndCap"/> <c>&lt;c:noEndCap&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValue"/> <c>&lt;c:val&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType"/> <c>&lt;c:errBarType&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection"/> <c>&lt;c:errDir&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType"/> <c>&lt;c:errValType&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ExtensionList"/> <c>&lt;c:extLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Plus"/> <c>&lt;c:plus&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Minus"/> <c>&lt;c:minus&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlElement(typeof(DXDC.ErrorBars))]
public partial class ErrorBars : ModelElement<DXDC.ErrorBars>
{
  /// <summary>
  ///   Direction of the error bar (e.g., X, Y, or both).
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorDirection))]
  public XlErrorBarDirection? ErrorDirection { get => _ErrorDirection; set => UpdateField(ref _ErrorDirection, value, nameof(ErrorDirection)); }
  private XlErrorBarDirection? _ErrorDirection;
  /// <summary>
  ///   Type of error bar, such as fixed value, percentage, or standard deviation.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorBarType))]
  public ErrorBarType? ErrorBarType { get => _ErrorBarType; set => UpdateField(ref _ErrorBarType, value, nameof(ErrorBarType)); }
  private ErrorBarType? _ErrorBarType;
  /// <summary>
  ///   Value type for the error bar, such as custom, standard error, or standard deviation.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorBarValueType))]
  public ErrorType? ErrorBarValueType { get => _ErrorBarValueType; set => UpdateField(ref _ErrorBarValueType, value, nameof(ErrorBarValueType)); }
  private ErrorType? _ErrorBarValueType;
  /// <summary>
  ///   Indicates whether the error bar is rendered without an end cap.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NoEndCap))]
  public bool? NoEndCap { get => _NoEndCap; set => UpdateField(ref _NoEndCap, value, nameof(NoEndCap)); }
  private bool? _NoEndCap;
  /// <summary>
  ///   Positive error range for the error bar.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Plus))]
  public Plus? Plus { get => _Plus; set => UpdateField(ref _Plus, value, nameof(Plus)); }
  private Plus? _Plus;
  /// <summary>
  ///   Negative error range for the error bar.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Minus))]
  public Minus? Minus { get => _Minus; set => UpdateField(ref _Minus, value, nameof(Minus)); }
  private Minus? _Minus;
  /// <summary>
  ///   Fixed value for the error bar, if applicable.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorBarValue))]
  public Double? ErrorBarValue { get => _ErrorBarValue; set => UpdateField(ref _ErrorBarValue, value, nameof(ErrorBarValue)); }
  private Double? _ErrorBarValue;
  /// <summary>
  ///   Shape and visual properties for the error bar.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }
  private ChartShapeProperties? _ChartShapeProperties;
  /// <summary>
  ///   Collection of extension elements for additional error bar customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}