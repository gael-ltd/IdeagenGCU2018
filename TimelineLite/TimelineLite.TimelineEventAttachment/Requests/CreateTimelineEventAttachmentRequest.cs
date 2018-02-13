﻿using Timelinelite.Core;

namespace TimelineLite.TimelineEventAttachment
{
    public class CreateTimelineEventAttachmentRequest : BaseRequest
    {
        public string AttachmentId;
        public string TimelineEventId;
        public string Title;
    }
}