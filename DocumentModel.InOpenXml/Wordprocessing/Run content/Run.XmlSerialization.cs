namespace DocumentModel.Wordprocessing;

public partial class Run : IXmlSerializable
{
  private static readonly Type[] acceptedTypes =
  [ typeof(RunText), typeof(LastRenderedPageBreak), typeof(FieldChar), typeof(FieldCode),
    typeof(TabChar), typeof(Break), typeof(SoftHyphen), typeof(NoBreakHyphen), typeof(SymbolChar),
    typeof(FootnoteReference), typeof(CommentReference),
  //  typeof(Drawing),
  //  typeof(AlternateContent)
    typeof(EmbeddedObject)
  ];

  /// <summary>
  /// Determines whether the current instance accepts an XML item of the specified type.
  /// This method can be overridden in derived classes to provide custom logic for accepting or rejecting specific item types.
  /// </summary>
  /// <param name="itemType">The type of the XML item to check.</param>
  /// <returns>True if the item is accepted; otherwise, false.</returns>
  protected override bool AcceptsXmlItem(Type itemType)
  {
    if (acceptedTypes.Contains(itemType))
      return true;
    Debug.WriteLine($"Checking if Run accepts XML item of type: {itemType.FullName}");
    return false;
  }

}