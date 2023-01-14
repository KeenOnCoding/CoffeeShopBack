using CoffeeShop.Domain.Events;
using Marten.Events.Projections;

namespace CoffeeShop.Domain.Views
{
    public class TabViewProjection : ViewProjection<TabView, Guid>
    {
        public TabViewProjection()
        {
            ProjectEvent<TabOpened>(ev => ev.TabId, (view, @event) => view.Apply(@event));
            ProjectEvent<TabClosed>(ev => ev.TabId, (view, @event) => view.Apply(@event));
            ProjectEvent<MenuItemsOrdered>(ev => ev.TabId, (view, @event) => view.Apply(@event));
            ProjectEvent<MenuItemsServed>(ev => ev.TabId, (view, @event) => view.Apply(@event));
            ProjectEvent<MenuItemsRejected>(ev => ev.TabId, (view, @event) => view.Apply(@event));
        }
    }
}