namespace DocumentModel.Drawings;
/// <summary>
///   Linear Gradient Fill.
/// </summary>
[XmlRoot("LinearGradientFill", Namespace = "DocumentModel.Drawings")]
public partial class LinearGradientFill : GradientFill
{
 /// <summary>
 ///   Angle
 /// </summary>
 public Int32? Angle { get; set; }

 /// <summary>
 ///   Scaled
 /// </summary>
 [DefaultValue(false)]
 public Boolean Scaled { get; set; }
}