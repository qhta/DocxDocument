using System.Windows.Controls;

namespace ModelGenApp.ViewHelpers;
public abstract class PropertyTemplateSelector : DataTemplateSelector
{
  private Delegate getPropertyValue = null!;

  public string PropertyName { get; set; } = null!;

  public Type ItemType { get; set; } = null!;

  public override DataTemplate SelectTemplate(object item, DependencyObject container)
  {
    if (ItemType.IsInstanceOfType(item))
    {
      if (getPropertyValue == null)
      {
        System.Linq.Expressions.ParameterExpression instanceParameter =
            System.Linq.Expressions.Expression.Parameter(item.GetType(), "p");

        System.Linq.Expressions.MemberExpression currentExpression =
            System.Linq.Expressions.Expression.PropertyOrField(instanceParameter, PropertyName);

        System.Linq.Expressions.LambdaExpression lambdaExpression =
            System.Linq.Expressions.Expression.Lambda(currentExpression, instanceParameter);

        getPropertyValue = lambdaExpression.Compile();
      }

      if (getPropertyValue != null)
      {
        var value =  getPropertyValue.DynamicInvoke(item);
        if (value != null)
          return SelectTemplateImpl(value, container);
      }
    }

    return base.SelectTemplate(item, container);
  }

  protected abstract DataTemplate SelectTemplateImpl(object propertyValue, DependencyObject container);
}
