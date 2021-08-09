import React, {useEffect, useState} from 'react';
import styled, {createGlobalStyle, ThemeProvider} from "styled-components";
import original from "react95/dist/themes/original";
import ms_sans_serif from "react95/dist/fonts/ms_sans_serif.woff2";
import ms_sans_serif_bold from "react95/dist/fonts/ms_sans_serif_bold.woff2";
import MessagesGrid from "./MessagesGrid";
import ActionCards from "./ActionCards";

const GlobalStyles = createGlobalStyle`
  @font-face {
    font-family: 'ms_sans_serif';
    src: url('${ms_sans_serif}') format('woff2');
    font-weight: 400;
    font-style: normal
  }
  @font-face {
    font-family: 'ms_sans_serif';
    src: url('${ms_sans_serif_bold}') format('woff2');
    font-weight: bold;
    font-style: normal
  }
  body {
    font-family: 'ms_sans_serif';
    background-color: teal;
  } 
`;

const Container = styled.div`
    display: flex;
    column-gap: 1em;
    @media (max-width: 800px) {
      flex-direction: column;
      gap: initial;
    }  
`;

const Home = () => {
    const [messages, setMessages] = useState([]);

    useEffect(() => {
        fetch('/api/Messages/Limit/10', {
            method: 'GET',
            headers: {
                'Accept': 'application/json'
            }
        }).then(response =>
            response.json().then(data => setMessages(data)));
    }, [setMessages]);

    return (
        <>
            <GlobalStyles/>
            <ThemeProvider theme={original}>
                <Container>
                    <ActionCards setMessages={setMessages}/>
                    <MessagesGrid messages={messages}/>
                </Container>
            </ThemeProvider>
        </>
    );
}

export default Home;