namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Upper-Limit object, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
[OpenXmlType(typeof(DXM.LimitUpper))]
public partial class LimitUpper : ModelElement<DXM.LimitUpper>, ICommonMathContent
{
 /// <summary>
 ///   Upper Limit Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.LimitUpper.LimitUpperProperties))]
 public LimitUpperProperties? LimitUpperProperties { get => _LimitUpperProperties; set => UpdateField(ref _LimitUpperProperties, value, nameof(LimitUpperProperties)); }

 private LimitUpperProperties? _LimitUpperProperties;
 /// <summary>
 ///   Argument.
 /// </summary>
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

 private Argument? _Argument;
 /// <summary>
 ///   Limit (Upper).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.LimitUpper.Limit))]
 public Limit? Limit { get => _Limit; set => UpdateField(ref _Limit, value, nameof(Limit)); }

 private Limit? _Limit;
}