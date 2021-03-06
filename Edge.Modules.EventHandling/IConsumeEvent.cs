using System;
using System.Threading.Tasks;

namespace RaaLabs.Edge.Modules.EventHandling
{
    public interface IConsumeEvent { }

    /// <summary>
    /// A class implementing this interface will have its Handle(T @event) function called whenever a new event of this
    /// type is produced.
    /// 
    /// </summary>
    /// <typeparam name="T">the type to consume</typeparam>
    public interface IConsumeEvent<in T> : IConsumeEvent
    {
        public void Handle(T @event);

    }

    /// <summary>
    /// A class implementing this interface will have its HandleAsync(T @event) function called whenever a new event of this
    /// type is produced.
    /// 
    /// </summary>
    /// <typeparam name="T">the type to consume</typeparam>
    public interface IConsumeEventAsync<in T> : IConsumeEvent
    {
        public Task HandleAsync(T @event);

    }
}
