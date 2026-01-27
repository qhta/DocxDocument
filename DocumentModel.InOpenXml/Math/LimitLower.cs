namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Lower-Limit object, consisting of text on the baseline 
///   and reduced-size text immediately below it. Examples of limLow include lim and max.
/// </summary>
[OpenXmlType(typeof(DXM.LimitLower))]
public partial class LimitLower : ModelElement<DXM.LimitLower>, ICommonMathContent
{
 /// <summary>
 ///   Lower Limit Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.LimitLower.LimitLowerProperties))]
 public LimitLowerProperties? LimitLowerProperties { get => _LimitLowerProperties; set => UpdateField(ref _LimitLowerProperties, value, nameof(LimitLowerProperties)); }

 private LimitLowerProperties? _LimitLowerProperties;
 /// <summary>
 ///   argument.
 /// </summary>
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

 private Argument? _Argument;
 /// <summary>
 ///   Limit (lower.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.LimitLower.Limit))]
 public Limit? Limit { get => _Limit; set => UpdateField(ref _Limit, value, nameof(Limit)); }

 private Limit? _Limit;
}