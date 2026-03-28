namespace DocumentModel.Interop;

public partial interface SmartTags
{
  /// <summary>
  /// Adds a new smart tag to the collection.
  /// </summary>
  /// <param name="Name">The name of the smart tag type.</param>
  /// <param name="Range">The range to which the smart tag is applied.</param>
  /// <param name="Properties">The properties for the smart tag.</param>
  /// <returns>The created <see cref="SmartTag"/> object.</returns>
  public SmartTag Add(string Name, object Range, object Properties);

  /// <summary>
  /// Returns a collection of smart tags of the specified type.
  /// </summary>
  /// <param name="Name">The name of the smart tag type to retrieve.</param>
  /// <returns>The <see cref="SmartTags"/> collection for the specified type.</returns>
  public SmartTags SmartTagsByType(string Name);
}
