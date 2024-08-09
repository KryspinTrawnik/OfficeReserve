using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeReserve.Api.Models;

namespace OfficeReserve.Api.Controllers
{
    /// <summary>
    /// Handles notifications for bookings and reminders.
    /// </summary>
    [Route("api/notifications")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        /// <summary>
        ///  Get a list of all notifications.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetAllNotifications()
        {
            return "List of all notifications";
        }

        /// <summary>
        ///  Send a custom notification (admin only).
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> SendNotfication()
        {
            return "Send a notification";
        }

        /// <summary>
        ///   Get details of a specific notification.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetNotfication()
        {
            return "Get a notification";
        }

        /// <summary>
        /// Update an existing notification (admin only).
        /// </summary>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> UpdateNotification()
        {
            return "Notification updated";
        }

        /// <summary>
        /// Delete a notification (admin only).
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> DeleteNotification()
        {
            return "Notification deleted";
        }

        /// <summary>
        /// Mark a notification as read.
        /// </summary>
        [HttpPut("{id}/read")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> MarkNotificationAsRead()
        {
            return "Notification marked as read";
        }

        /// <summary>
        /// Get a list of all unread notifications.
        /// </summary>
        [HttpGet("unread")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetUnreadNotifications()
        {
            return "List of unread notifications";
        }
        /// <summary>
        /// Schedule a notification to be sent later (admin only).
        /// </summary>
        [HttpPost("schedule")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> ScheduleNotification()
        {
            return "Notification scheduled";
        }

        /// <summary>
        /// Get the history of all sent notifications.
        /// </summary>
        [HttpGet("history")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetNotificationHistory()
        {
            return "List of sent notifications";
        }

    }
}
