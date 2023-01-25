

namespace DocumentModel.Properties;

/// <summary>
///   Heading Pairs.
/// </summary>
[TypeConverter(typeof(HeadingPairsTypeConverter))]
public class HeadingPairs : Collection<StringNum>
{
}