import React, {useState} from 'react';
import {Button, Fieldset, TextField} from "react95";
import WindowWrapper from "./WindowWrapper";

const Content = () => {
    const [to, setTo] = useState('');
    const [content, setContent] = useState('');

    const onSubmit = event => {
        event.preventDefault();
        fetch('/api/Messages', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                To: to,
                Content: content
            })
        });
    }

    return (
        <>
            <Fieldset label='To'>
                <TextField
                    value={to}
                    onChange={event => setTo(event.target.value)}
                    placeholder='Type their name here...'
                    fullWidth/>
            </Fieldset>
            <Fieldset label='Content'>
                <TextField
                    value={content}
                    onChange={event => setContent(event.target.value)}
                    multiline
                    rows={4}
                    placeholder='Write your message here...'
                    fullWidth/>
                <br/>
                <small>{content.length} / 140</small>
            </Fieldset>
            <br/>
            <Button
                onClick={onSubmit}
                disabled={to.length === 0 || content.length === 0}
                fullWidth>Submit</Button>
        </>
    );
}

const SendAMessageCard = () => {
    return (
        <WindowWrapper
            header={<span>Send A Message</span>}
            content={<Content/>}/>
    );
}

export default SendAMessageCard;