namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of grid columns in a table within a Wordprocessing document.
/// This class provides access to and management of <see cref="GridColumn"/> elements, enabling configuration of column structure and widths for tables.
/// </summary>
public class GridColumns<T>: ModelElementCollection<GridColumn, T, DXW.GridColumn> 
  where T : DX.OpenXmlCompositeElement
{
    
}