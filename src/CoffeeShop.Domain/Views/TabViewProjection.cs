using CoffeeShop.Domain.Events;
using Marten.Events.Projections;

namespace CoffeeShop.Domain.Views
{
    public class TabViewProjection : MultiStreamAggregation<TabView, Guid>
    {
        public TabViewProjection()
        {
            Identity<TabOpened>(ev => ev.TabId);
            Identity<TabClosed>(ev => ev.TabId);
            Identity<MenuItemsOrdered>(ev => ev.TabId);
            Identity<MenuItemsServed>(ev => ev.TabId);
            Identity<MenuItemsRejected>(ev => ev.TabId);
        }
        public void Apply(TabOpened @event, TabView view)=> view.Apply(@event);
        public void Apply(TabClosed @event, TabView view) => view.Apply(@event);
        public void Apply(MenuItemsOrdered @event, TabView view) => view.Apply(@event);
        public void Apply(MenuItemsServed @event, TabView view) => view.Apply(@event);
        public void Apply(MenuItemsRejected @event, TabView view) => view.Apply(@event);

    }
}