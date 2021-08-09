import React from 'react';
import styled from "styled-components";
import MessageCard from "./MessageCard";

const MessagesContainer = styled.div`
  flex-basis: 66.66%;
  > div {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(25em, 1fr));
    grid-column-gap: 2em;
    grid-row-gap: 2em;
  }
`;

export const MessagesGrid = ({messages}) => {
    return (
        <MessagesContainer>
            <div>
                {messages.map(({to, content, createdAt}, index) =>
                    <MessageCard
                        key={index}
                        to={to}
                        content={content}
                        createdAt={createdAt}/>)}
            </div>
        </MessagesContainer>
    );
}

export default MessagesGrid;