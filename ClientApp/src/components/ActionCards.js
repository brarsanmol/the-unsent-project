import styled from 'styled-components';
import MessagesSearchBox from "./MessagesSearchBox";
import SendAMessageCard from "./SendAMessageCard";
import About from "./About";
import React from "react";

const ActionsContainer = styled.div`
  flex-basis: 33%;
  > * {
    margin-bottom: 2em;
  }
`;

const ActionCards = ({setMessages}) => {
    return (
        <ActionsContainer>
            <MessagesSearchBox setMessages={setMessages}/>
            <SendAMessageCard/>
            <About/>
        </ActionsContainer>
    );
}

export default ActionCards;