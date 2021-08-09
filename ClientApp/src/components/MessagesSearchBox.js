import React, {useState} from "react";
import {Button, Checkbox, TextField} from "react95";
import WindowWrapper from "./WindowWrapper";

const Content = ({setMessages}) => {
    const [to, setTo] = useState('');
    const [exact, setExact] = useState(false);

    const onSubmit = event => {
        event.preventDefault();
        fetch("/api/Messages/" + (!!to ? `${to}?exact=${exact}` : `Limit/10`), {
            method: 'GET',
            headers: {
                'Accept': 'application/json'
            }
        })
            .then(response =>
                response.json().then(data => setMessages(data)));
    }

    return (
        <>
            <TextField
                value={to}
                onChange={event => setTo(event.target.value)}
                placeholder='Type a name here...'
                fullWidth
            />
            <Checkbox
                checked={exact}
                onChange={() => setExact(!exact)}
                name='exact'
                value='exact'
                label='Exact'
            />
            <br/>
            <Button onClick={onSubmit} fullWidth>Go!</Button>
        </>
    );
}

const MessagesSearchBox = ({setMessages}) => {
    return (
        <WindowWrapper
            header={<span>Search</span>}
            content={<Content setMessages={setMessages}/>}/>
    );
}

export default MessagesSearchBox;