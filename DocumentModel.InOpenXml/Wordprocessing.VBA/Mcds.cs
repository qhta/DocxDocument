namespace DocumentModel.Wordprocessing.VBA;
/// <summary>
/// Represents a collection of macro data structures (Mcd) for VBA in a Wordprocessing document.
/// This class provides access to and management of <see cref="Mcd"/> elements, enabling the storage and organization of supplementary macro-related data for VBA-enabled documents.
/// </summary>
[OpenXmlType(typeof(DXOW.Mcds))]
public class Mcds : ModelElementCollection<Mcd, DXOW.Mcds, DXOW.Mcd>
{
}