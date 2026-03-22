namespace DocumentModel.Math;
/// <summary>
///   This element specifies the phantom object. This object has two primary uses: 
///   adding the spacing of the phantom base element e without displaying that base; 
///   and suppressing part of the glyph for spacing considerations.
/// </summary>
[OpenXmlType(typeof(DXM.Phantom))]
public partial class Phantom : ModelElement<DXM.Phantom>, ICommonMathContent
{
 /// <summary>
 ///   Phantom Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Phantom.PhantomProperties))]
 public PhantomProperties? PhantomProperties { get => _PhantomProperties; set => UpdateField(ref _PhantomProperties, value, nameof(PhantomProperties)); }
 private PhantomProperties? _PhantomProperties;
 /// <summary>
 ///   Phantom object argument.
 /// </summary>
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }
 private Argument? _Argument;
}