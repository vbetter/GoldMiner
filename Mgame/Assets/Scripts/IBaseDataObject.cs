using System;
using System.Reflection;

public abstract class IBaseDataObject
{
    public virtual Type TypeForName(string name)
    {
        PropertyInfo propertyInfo = this.GetType().GetProperty(name);
        if (propertyInfo != null)
        {
            return propertyInfo.GetType();
        }
        return null;
    }

    public virtual void OnLoadedFinish()
    {

    }
}
