namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the LayoutVariablePropertySetType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutVariablePropertySetType))]
public abstract partial class LayoutVariablePropertySetType<T> : ModelElement<T> where T : DXDD.LayoutVariablePropertySetType
{
  /// <summary>
  ///   Show Organization Chart User class.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.OrganizationChart))]
  public bool? OrganizationChart { get => _OrganizationChart; set => UpdateField(ref _OrganizationChart, value, nameof(OrganizationChart)); }
  private bool? _OrganizationChart;
  /// <summary>
  ///   Maximum Children.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.MaxNumberOfChildren))]
  public Int32? MaxNumberOfChildren { get => _MaxNumberOfChildren; set => UpdateField(ref _MaxNumberOfChildren, value, nameof(MaxNumberOfChildren)); }
  private Int32? _MaxNumberOfChildren;
  /// <summary>
  ///   Preferred Number of Children.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.PreferredNumberOfChildren))]
  public Int32? PreferredNumberOfChildren { get => _PreferredNumberOfChildren; set => UpdateField(ref _PreferredNumberOfChildren, value, nameof(PreferredNumberOfChildren)); }
  private Int32? _PreferredNumberOfChildren;
  /// <summary>
  ///   Show Insert Bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.BulletEnabled))]
  public bool? BulletEnabled { get => _BulletEnabled; set => UpdateField(ref _BulletEnabled, value, nameof(BulletEnabled)); }
  private bool? _BulletEnabled;
  /// <summary>
  ///   Diagram Direction.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.Direction))]
  public Direction? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }
  private Direction? _Direction;
  /// <summary>
  ///   Organization Chart Branch Style.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.HierarchyBranch))]
  public HierarchyBranchStyle? HierarchyBranch { get => _HierarchyBranch; set => UpdateField(ref _HierarchyBranch, value, nameof(HierarchyBranch)); }
  private HierarchyBranchStyle? _HierarchyBranch;
  /// <summary>
  ///   One by One Animation String.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.AnimateOneByOne))]
  public AnimateOneByOne? AnimateOneByOne { get => _AnimateOneByOne; set => UpdateField(ref _AnimateOneByOne, value, nameof(AnimateOneByOne)); }
  private AnimateOneByOne? _AnimateOneByOne;
  /// <summary>
  ///   Level Animation.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.AnimationLevel))]
  public AnimationLevelString? AnimationLevel { get => _AnimationLevel; set => UpdateField(ref _AnimationLevel, value, nameof(AnimationLevel)); }
  private AnimationLevelString? _AnimationLevel;
  /// <summary>
  ///   Shape Resize Style.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.LayoutVariablePropertySetType.ResizeHandles))]
  public ResizeHandlesString? ResizeHandles { get => _ResizeHandles; set => UpdateField(ref _ResizeHandles, value, nameof(ResizeHandles)); }
  private ResizeHandlesString? _ResizeHandles;
}
/// <summary>
/// Concrete LayoutVariablePropertySetType class.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutVariablePropertySetType))]
public partial class LayoutVariablePropertySetType: LayoutVariablePropertySetType<DXDD.LayoutVariablePropertySetType>
{
}
