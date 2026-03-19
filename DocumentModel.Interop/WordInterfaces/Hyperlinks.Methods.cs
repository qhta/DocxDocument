namespace DocumentModel.Interop.Word;

public partial interface Hyperlinks
{
  /// <summary>
  /// Adds a new Hyperlink to the collection. 
  /// </summary>
  /// <param name="Anchor">The object to which the Hyperlink is anchored.</param>
  /// <param name="Address">The address of the Hyperlink.</param>
  /// <param name="SubAddress">The sub-address of the Hyperlink.</param>
  /// <returns>The newly created <see cref="Hyperlink"/> object.</returns>
  public Hyperlink _Add(object Anchor, object Address, object SubAddress);

  /// <summary>
  /// Adds a new hyperlink to the collection at the specified anchor location.
  /// </summary>
  /// <remarks>If both Address and SubAddress are specified, the hyperlink will navigate to the specified
  /// location within the destination. All parameters are optional, but at least one of Address or SubAddress should be
  /// provided to create a functional hyperlink.</remarks>
  /// <param name="Anchor">The anchor object that defines where the hyperlink will be added. This is typically a range or shape in the
  /// document.</param>
  /// <param name="Address">The address of the hyperlink destination. This can be a URL, file path, or email address. Can be null to create a
  /// hyperlink with only a subaddress.</param>
  /// <param name="SubAddress">The location within the destination specified by Address, such as a bookmark or named location. Can be null if not
  /// applicable.</param>
  /// <param name="ScreenTip">The text to display as a tooltip when the user hovers over the hyperlink. Can be null for no tooltip.</param>
  /// <param name="TextToDisplay">The text to display for the hyperlink in the document. If null, the address or subaddress may be used as the
  /// display text.</param>
  /// <param name="Target">The name of the target window or frame in which to open the hyperlink. Can be null to use the default behavior.</param>
  /// <returns>A Hyperlink object representing the newly added hyperlink.</returns>
  public Hyperlink Add(object Anchor, object Address, object SubAddress, object ScreenTip, object TextToDisplay, object Target);
}
