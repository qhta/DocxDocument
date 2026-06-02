namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Template objects that represent all the templates that are currently available.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.templates?view=word-pia"/>
public partial interface ITemplates : IInteropObject, IInteropCollection<Template>
{


  #region methods

/// <summary>
  /// Loads the building blocks for all templates into Microsoft Office Word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.templates.loadbuildingblocks?view=word-pia"/>
  public void LoadBuildingBlocks();

  #endregion methods
}
