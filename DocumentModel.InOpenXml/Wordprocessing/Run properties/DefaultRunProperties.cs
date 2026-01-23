namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the default run properties for text formatting in a WordprocessingML document.
  /// This class extends <see cref="BaseRunProperties"/> and is used in <see cref="DocDefaults"/> to specify the default character-level formatting applied to all runs in the document unless overridden by more specific formatting.
  /// </summary>
  public class DefaultRunProperties : BaseRunProperties<DXD.DefaultRunProperties>
  {
  }