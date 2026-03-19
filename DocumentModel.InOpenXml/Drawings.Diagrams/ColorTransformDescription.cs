namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Description.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformDescription))]
/// <summary>
/// Represents the Color Transform Description.
/// </summary>
public class ColorTransformDescription : ModelElement<DXDD.ColorTransformDescription>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformDescription.Language))]
 /// <summary>
 /// Language.
 /// </summary>
 public string? Language { get; set; }

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformDescription.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public string? Val { get; set; }
}

