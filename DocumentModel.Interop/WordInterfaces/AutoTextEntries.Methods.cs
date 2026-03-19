namespace DocumentModel.Interop.Word;

public partial interface AutoTextEntries
{
  /// <summary>
  /// Creates a new AutoText entry from the specified range.
  /// </summary>
  /// <param name="Name">The name of the AutoText entry.</param>
  /// <param name="Range">The range whose contents are stored in the AutoText entry.</param>
  /// <returns>The created <see cref="AutoTextEntry"/> object.</returns>
  public AutoTextEntry Add(string Name, Range Range);

  /// <summary>
  /// Appends the specified range to the Spike AutoText entry.
  /// </summary>
  /// <param name="Range">The range to append to the Spike entry.</param>
  /// <returns>The Spike <see cref="AutoTextEntry"/> object.</returns>
  public AutoTextEntry AppendToSpike(Range Range);
}
