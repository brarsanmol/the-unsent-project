import React from 'react';
import {Fieldset} from "react95";
import {format} from "date-fns";
import WindowWrapper from "./WindowWrapper";
import {toPng} from 'html-to-image';
import * as download from 'downloadjs';

const Content = ({content, createdAt}) => {
    return (
        <>
            <Fieldset label='Content'>
                <p>{content}</p>
            </Fieldset>
            <br/>
            <small>
                <strong>Sent On: </strong>
                {format(new Date(createdAt), 'MMMM do yyyy \'at\' h:mm a')}
            </small>
        </>
    );
}

const MessageCard = ({to, content, createdAt}) => {
    const onClick = () =>
        toPng(document.getElementById(to + "-" + createdAt + content.length))
            .then(data => download(data, to + "-" + createdAt + ".png"));

    return (
        <WindowWrapper
            id={to + "-" + createdAt + content.length}
            header={<span>To: {to}</span>}
            content={<Content content={content} createdAt={createdAt}/>}
            button={onClick}/>
    );
}

export default MessageCard;