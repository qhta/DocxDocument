namespace DocumentModel;
/// <summary>
///   Heading Pairs.
/// </summary>
public class HeadingPairs : ElementCollection<HeadingPair>, ICollectionItem
{
  public ElementCollection<CollectionItem>? Collection { get; set; }
}