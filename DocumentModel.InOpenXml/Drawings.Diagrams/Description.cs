namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Description.
/// </summary>
[OpenXmlType(typeof(DXDD.Description))]
/// <summary>
/// Represents the Description.
/// </summary>
public class Description : ModelElement<DXDD.Description>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Description.Language))]
 /// <summary>
 /// Language.
 /// </summary>
 public string? Language { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Description.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public string? Val { get; set; }
}

