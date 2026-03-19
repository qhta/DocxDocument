namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.Title))]
/// <summary>
/// Represents the Title.
/// </summary>
public class Title : ModelElement<DXDD.Title>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Title.Language))]
 /// <summary>
 /// Language.
 /// </summary>
 public string? Language { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Title.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public string? Val { get; set; }
}

