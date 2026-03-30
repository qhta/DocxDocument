namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of TwoInitialCapsException objects that represent all the items listed in the Don't correct box
/// on the INitial CAps tab in the AutoCorrect Exceptions dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexceptions?view=word-pia"/>
public partial interface TwoInitialCapsExceptions : IModelObject, IModelCollection<TwoInitialCapsException>
{
}
