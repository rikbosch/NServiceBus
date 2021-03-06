using System;

namespace NServiceBus.Unicast
{
    /// <summary>
    /// Extension of the IBus interface for working with a distributor.
    /// </summary>
    public interface IUnicastBus : IBus
    {
        /// <summary>
        /// Event raised by the Publish method when no subscribers are
        /// registered for the message being published.
        /// </summary>
        event EventHandler<MessageEventArgs> NoSubscribersForMessage;

        /// <summary>
        /// Event raised when a client has been subscribed to a message type.
        /// </summary>
        event EventHandler<SubscriptionEventArgs> ClientSubscribed;

        /// <summary>
        /// Event raised when the bus sends multiple messages across the wire.
        /// </summary>
        event EventHandler<MessagesEventArgs> MessagesSent;
    }
}